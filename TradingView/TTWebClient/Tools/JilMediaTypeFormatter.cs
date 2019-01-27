using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Jil;

namespace TTWebClient.Domain.Tools
{
    /// <summary>
    /// Jil media type formatter
    /// </summary>
    public class JilMediaTypeFormatter : MediaTypeFormatter
    {
        private static readonly MediaTypeHeaderValue _applicationJsonMediaType = new MediaTypeHeaderValue("application/json");
        private static readonly Task<bool> _done = Task.FromResult(true);

        private readonly Options _options;

        /// <summary>
        /// Constructor with options
        /// </summary>
        public JilMediaTypeFormatter(Options options)
        {
            _options = options;
            SupportedMediaTypes.Add(_applicationJsonMediaType);

            SupportedEncodings.Add(new UTF8Encoding(false, true));
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public JilMediaTypeFormatter() : this(GetDefaultOptions()) { }

        private static Options GetDefaultOptions()
        {
            return new Options(prettyPrint: true, excludeNulls: true, dateFormat: DateTimeFormat.MillisecondsSinceUnixEpoch, unspecifiedDateTimeKindBehavior: UnspecifiedDateTimeKindBehavior.IsUTC);
        }

        /// <summary>
        /// Read check handler
        /// </summary>
        public override bool CanReadType(Type type)
        {
            return true;
        }

        /// <summary>
        /// Write check handler
        /// </summary>
        public override bool CanWriteType(Type type)
        {
            return true;
        }

        /// <summary>
        /// Read handler
        /// </summary>
        public override Task<object> ReadFromStreamAsync(Type type, Stream input, HttpContent content, IFormatterLogger formatterLogger)
        {
            var reader = new StreamReader(input);
            var deserialize = TypedDeserializers.GetTyped(type);
            var result = deserialize(reader, _options);
            return Task.FromResult(result);
        }

        /// <summary>
        /// Write handler
        /// </summary>
        public override Task WriteToStreamAsync(Type type, object value, Stream output, HttpContent content, TransportContext transportContext)
        {
            var writer = new StreamWriter(output);
            JSON.Serialize(value, writer, _options);
            writer.Flush();
            return _done;
        }
    }

    static class TypedDeserializers
    {
        private static readonly ConcurrentDictionary<Type, Func<TextReader, Options, object>> _methods;
        private static readonly MethodInfo _method = typeof(JSON).GetMethod("Deserialize", new[] { typeof(TextReader), typeof(Options) });

        static TypedDeserializers()
        {
            _methods = new ConcurrentDictionary<Type, Func<TextReader, Options, object>>();
        }

        public static Func<TextReader, Options, object> GetTyped(Type type)
        {
            return _methods.GetOrAdd(type, CreateDelegate);
        }

        private static Func<TextReader, Options, object> CreateDelegate(Type type)
        {
            return (Func<TextReader, Options, object>)_method
                .MakeGenericMethod(type)
                .CreateDelegate(typeof(Func<TextReader, Options, object>));
        }
    }
}

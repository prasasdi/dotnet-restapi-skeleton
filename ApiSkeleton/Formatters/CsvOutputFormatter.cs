using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using Shared.DataTransferableObject;
using System.Text;

namespace ApiSkeleton.Formatters
{
    public class CsvOutputFormatter : TextOutputFormatter
    {
        public CsvOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }
        protected override bool CanWriteType(Type? type)
        {
            if (typeof(ClassGroupDto).IsAssignableFrom(type) ||
           typeof(IEnumerable<ClassGroupDto>).IsAssignableFrom(type))
            {
                return base.CanWriteType(type);
            }
            return false;
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var response = context.HttpContext.Response;
            var buffer = new StringBuilder();
            if (context.Object is IEnumerable<ClassGroupDto>)
            {
                foreach (var classGroup in (IEnumerable<ClassGroupDto>)context.Object)
                {
                    FormatCsv(buffer, classGroup);
                }
            }
            else
            {
                FormatCsv(buffer, (ClassGroupDto)context.Object);
            }
            await response.WriteAsync(buffer.ToString());
        }
        private static void FormatCsv(StringBuilder buffer, ClassGroupDto classGroup)
        {
            buffer.AppendLine($"{classGroup.Id},\"{classGroup.Name}\"");
        }

    }
}

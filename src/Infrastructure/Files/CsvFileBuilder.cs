using System.Globalization;
using MechanicApp.Application.Common.Interfaces;
using MechanicApp.Application.TodoLists.Queries.ExportTodos;
using MechanicApp.Infrastructure.Files.Maps;
using CsvHelper;

namespace MechanicApp.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}

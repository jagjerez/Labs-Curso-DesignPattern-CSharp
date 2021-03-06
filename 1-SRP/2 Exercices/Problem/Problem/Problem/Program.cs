﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new CourseReport();
            report.AddEntry(new CourseReportEntry{ Name = "Patrones de diseño", Students= 1000, Rating = 5 });
            report.AddEntry(new CourseReportEntry { Name = "Flutter", Students = 1900, Rating = 4.5 });

            Console.WriteLine(report.ToString());
            ReportPrint.SaveToFile(@"Reports", "WorkReport.txt", report.ToString());
        }
    }

    public class CourseReportEntry
    {
        public string Name { get; set; }
        public int Students { get; set; }
        public double Rating { get; set; }
    }

    public class CourseReport
    {
        private readonly List<CourseReportEntry> _entries;

        public CourseReport()
        {
            _entries = new List<CourseReportEntry>();
        }

        public void AddEntry(CourseReportEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Curso: {x.Name}, Estudiantes: {x.Students}, Valoración: {x.Rating}"));
    }

    public static class ReportPrint
    {
        public static void SaveToFile(string directoryPath, string fileName,string texto)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), texto);
        }
    }


}

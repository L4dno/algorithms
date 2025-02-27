﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace algo.ozon_jan
{
    internal class ozon_4
    {
        class Directory
        {
            [JsonPropertyName("dir")]
            public string name { get; set; } = string.Empty;
            [JsonPropertyName("files")]
            public List<string> fileNames { get; set; } = new List<string>();
            [JsonPropertyName("folders")]
            public List<Directory> dirNames { get; set; } = new List<Directory>();
        }
        static int Count(Directory cur, bool hasVirus)
        {
            int cntCorrupted = 0;
            
            string pattern = @"\.hack";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            foreach (string name in cur.fileNames)
                    hasVirus = hasVirus | regex.IsMatch(name);

            if (hasVirus)
            {
                cntCorrupted += cur.fileNames.Count;
            }

            foreach (Directory dir in cur.dirNames)
            {
                cntCorrupted += Count(dir, hasVirus);
            }
            return cntCorrupted;
        }
        static public void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(input.ReadLine());
                StringBuilder sb = new();
                for (int i = 0;i<n;++i)
                {
                    sb.Append(input.ReadLine());
                }
                var options = new JsonSerializerOptions
                {
                    MaxDepth = 1024
                };
                Directory root = JsonSerializer.Deserialize<Directory>(sb.ToString(), options);
                output.WriteLine(Count(root, false));
            }
        }
    }
}

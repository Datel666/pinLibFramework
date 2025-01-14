﻿using camShotTeaching.Enums;
using camShotTeaching.Structs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camShotTeaching.Training
{
    public static class Details
    {
        public static List<T> GetDetails<T>(string[] filesPath, TypeDetail type) where T : class
        {
            var details = new List<T>();

            foreach (var file in filesPath.OrderBy(s => s))
            {
                details.Add((T)(object)GetDetail(file, type));
            }

            return details;
        }

        public static Detail GetDetail(string filePath, TypeDetail type)
        {
            using (var str = new StreamReader(filePath, Encoding.UTF8))
            {
                var info = new FileInfo(filePath);

                var fileText = str.ReadToEnd();
                var mas = fileText.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                var resultK = new List<double[]>();

                foreach (var item in mas)
                {
                    var masK = item.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                    var k = new double[masK.Length];

                    for (int i = 0; i < masK.Length; i++)
                    {
                        k[i] = Convert.ToDouble(masK[i]);
                    }

                    resultK.Add(k);
                }

                return new Detail(resultK, info.Name, type);
            }
        }
    }
}

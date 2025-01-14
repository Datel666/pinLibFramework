﻿using camShotTeaching.Enums;
using camShotTeaching.Structs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camShotTeaching.Structs
{
    public struct Detail : IDetail, IDetailError
    {
        private IList<double[]> _standartsLearn;
        private string _nameObject;

        private int _countError;

        public IList<double[]> Standarts => _standartsLearn.ToList();
        public string Name => _nameObject;
        public int CountError => _countError;

        public Detail(List<double[]> standarts, string nameObject, TypeDetail type)
        {
            var del = (int)(standarts.Count * 0.8);

            var setStandart = new List<double[]>();

            switch (type)
            {
                case TypeDetail.All:
                    setStandart = standarts;
                    break;
                case TypeDetail.Train:
                    setStandart = standarts.GetRange(0, del);
                    break;
                case TypeDetail.Test:
                    setStandart = standarts.GetRange(del - 1, standarts.Count - del);
                    break;
                default:
                    break;
            }

            _standartsLearn = setStandart;
            _nameObject = nameObject.Substring(0, nameObject.LastIndexOf('.'));
            _countError = 0;
        }

        public void SetError(int errorCount)
        {
            _countError = errorCount;
        }
    }
}

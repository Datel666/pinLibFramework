using camShotTeaching.Structs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camShotTeaching.Contour
{
    public static class CountingAlgoritm
    {
        public static ConnectedPoints CountPoints(List<Point> points)
        {
            //Переменная с результатом выполнения
            var result = new ConnectedPoints
            {
                K = 0,
                T = 0,
                pointsK = new List<Point>(),
                pointsT = new List<Point>()
            };

            foreach (var item in points)
            {
                //Проверка на существования точек, соответствующих маскам g1 и g2
                if (points.Contains(new Point(item.X + 1, item.Y)) && points.Contains(new Point(item.X - 1, item.Y)) ||
                    points.Contains(new Point(item.X, item.Y + 1)) && points.Contains(new Point(item.X, item.Y - 1)))
                {
                    result.K++;
                    result.pointsK.Add(item);
                }

                //Проверка на существования точек, соответствующих маскам g3 и g4
                if (points.Contains(new Point(item.X - 1, item.Y + 1)) && points.Contains(new Point(item.X + 1, item.Y - 1)) ||
                    points.Contains(new Point(item.X - 1, item.Y - 1)) && points.Contains(new Point(item.X + 1, item.Y + 1)))
                {
                    result.T++;
                    result.pointsT.Add(item);
                }

            }

            return result;

        }
    }
}

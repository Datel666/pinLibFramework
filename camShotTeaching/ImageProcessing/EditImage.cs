using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camShotTeaching.ImageProcessing
{
    public static class EditImage
    {
        public static Image<Gray, byte> RotateImages(Image<Gray, byte> img, double angle)
        {
            return img.Rotate(angle, new Gray(255));
        }

        public static Image<Gray, byte> ConvertToGray(Image<Bgr, byte> img)
        {
            return img.Convert<Gray, byte>();
        }
        public static Image<Gray, byte> FilterImage(Image<Gray, byte> img)
        {
            CvInvoke.MedianBlur(img, img, 3);
            return img;
        }
        public static Image<Gray, byte> BinarizationImages(Image<Gray, byte> img)
        {
            CvInvoke.Threshold(img, img, 150, 255, ThresholdType.Otsu);
            return img;
        }

        public static Image<Gray, byte> DeleteTheBackground(Image<Gray, byte> img, Image<Gray, byte> bimg)
        {
            var source = new ImageWrapper(img.ToBitmap());
            
            var result = new System.Drawing.Bitmap(source.Width, source.Height);

            var mask = new ImageWrapper(bimg.ToBitmap());

            var en = source.GetEnumerator();


            while (en.MoveNext())
            {
                var point = en.Current;
                var color = mask[point].GetBrightness() == 1 ? System.Drawing.Color.White : source[point];
                result.SetPixel(point.X, point.Y, color);
            }
            Image<Gray, byte> image = new Image<Gray, byte>(result);

            return image;

        }
    }
}

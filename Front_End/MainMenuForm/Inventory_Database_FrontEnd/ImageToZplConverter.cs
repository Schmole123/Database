using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Drawing.Imaging;
using QRCoder;

namespace Inventory_Database_FrontEnd
{
    class ImageToZplConverter
    {
        // Modify this method to accept a Bitmap directly
        public async Task<string> ConvertImageToZplAsync(Bitmap image)
        {
            // Check if the input bitmap is null
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "Input bitmap cannot be null.");
            }

            using (var client = new HttpClient())
            using (var form = new MultipartFormDataContent())
            {
                // Convert the Bitmap to a MemoryStream
                using (var memoryStream = new MemoryStream())
                {
                    // Save the bitmap to the memory stream as a PNG image
                    // Labelary API prefers PNG for graphics
                    image.Save(memoryStream, ImageFormat.Png);

                    // Reset the stream's position to the beginning before reading
                    memoryStream.Position = 0;

                    using (var content = new StreamContent(memoryStream))
                    {
                        content.Headers.ContentType = MediaTypeHeaderValue.Parse("image/png");
                        // The filename "image.png" is just a convention for the API, not a real file path
                        form.Add(content, "file", "image.png");

                        HttpResponseMessage response = await client.PostAsync("http://api.labelary.com/v1/graphics", form);
                        response.EnsureSuccessStatusCode(); // Throws an exception for HTTP error codes
                        string zpl = await response.Content.ReadAsStringAsync();
                        return zpl;
                    }
                }
            }
        }

        public Bitmap GenerateQrCodeBitmap(string serial)
        {
          
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qrGenerator.CreateQrCode(serial, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap qrCodeImage = qRCode.GetGraphic(5); // Converts to BITMAP
            Bitmap resized = new Bitmap(qrCodeImage, new Size(64, 64));
            return resized;
        }
    }

}


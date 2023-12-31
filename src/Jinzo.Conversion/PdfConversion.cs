/*
    Project: Jinzo (https://github.com/azazelm3dj3d/Jinzo)
    License: BSD 2-Clause
    Author: azazelm3dj3d (https://github.com/azazelm3dj3d)
*/

using System;
using Jinzo.Utilities;

namespace Jinzo.Conversion;

class PdfConversion
{
    public static void Convert(string htmlFile, string outputFile)
    {
        // Validate HTML file exists
        if (FileValidation.ValidateHtml(htmlFile)) {
            // Check operating system runtime
            if (Utilities.OsValidation.GetOS("Windows")) {
                var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
                htmlToPdf.GeneratePdfFromFile(htmlFile, null, outputFile);
            } else {
                throw new NotImplementedException();
            }
        }
    }
}
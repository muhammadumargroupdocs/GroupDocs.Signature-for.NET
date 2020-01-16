using System;
using System.Collections.Generic;

namespace GroupDocs.Signature.Examples.CSharp.BasicUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;
    
    public class SearchForBarcode
    {
        /// <summary>
        /// Search document for Barcode signature
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # SearchForBarcode : Search document for Barcode signature \n");

            // The path to the documents directory.
            string filePath = Constants.SAMPLE_SPREADSHEET_SIGNED;

            using (Signature signature = new Signature(filePath))
            {
                BarcodeSearchOptions options = new BarcodeSearchOptions()
                {
                    AllPages = true, // this value is set by default
                };

                // search for signatures in document
                List<BarcodeSignature> signatures = signature.Search<BarcodeSignature>(options);
                Console.WriteLine($"\nSource document ['{filePath}'] contains following signatures.");
                foreach (var barcodeSignature in signatures)
                {
                    Console.WriteLine($"Barcode signature found at page {barcodeSignature.PageNumber} with type {barcodeSignature.EncodeType.TypeName} and text {barcodeSignature.Text}");
                }
            }
        }
    }
}
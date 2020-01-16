using System;
using System.Collections.Generic;

namespace GroupDocs.Signature.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;

    public class SearchForMetadataAdvanced
    {
        /// <summary>
        /// Search document for metadata signature with applying specific options
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # SearchForMetadataAdvanced : Search document for metadata signature with applying specific options\n");

            // The path to the documents directory.
            string filePath = Constants.SAMPLE_PDF_SIGNED;

            using (Signature signature = new Signature(filePath))
            {
                MetadataSearchOptions options = new MetadataSearchOptions()
                {
                    Name = "Producer",
                    IncludeBuiltinProperties = true,
                    NameMatchType = TextMatchType.Contains
                };

                // search for signatures in document
                List<PdfMetadataSignature> signatures = signature.Search<PdfMetadataSignature>(options);
                Console.WriteLine("\nSource document contains following signatures.");
                foreach (var metadataSignature in signatures)
                {
                    Console.WriteLine("Metadata signature found. Name : {0}. Value: {1}", metadataSignature.Name, metadataSignature.Value);
                }
            }
        }
    }
}
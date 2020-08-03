﻿using System;

namespace GroupDocs.Signature.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;

    public class GetDocumentProcessHistory
    {
        /// <summary>
        /// Get document form fields and signatures information 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # GetDocumentProcessHistory : Get document process history\n");

            // The path to the documents directory.
            string filePath = Constants.SAMPLE_WORD_SIGNED;

            using (Signature signature = new Signature(filePath))
            {
                IDocumentInfo documentInfo = signature.GetDocumentInfo();
                // display document process history information
                Console.WriteLine($"Document Process logs information: count = {documentInfo.ProcessLogs.Count}");
                foreach (ProcessLog processLog in documentInfo.ProcessLogs)
                {
                    Console.WriteLine($" - operation [{processLog.Type}] on {processLog.Date.ToShortDateString()}. Succedded/Failed {processLog.Succeeded}/{processLog.Failed}. Message: {processLog.Message}");
                }
            }
        }
    }
}
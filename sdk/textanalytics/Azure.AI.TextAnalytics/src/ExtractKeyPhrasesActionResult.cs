﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.AI.TextAnalytics.Models;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// The result of the execution of an <see cref="ExtractKeyPhrasesAction"/> on the input documents.
    /// </summary>
    public class ExtractKeyPhrasesActionResult : TextAnalyticsActionResult
    {
        private readonly ExtractKeyPhrasesResultCollection _documentsResults;

        internal ExtractKeyPhrasesActionResult(ExtractKeyPhrasesResultCollection result, DateTimeOffset completedOn, TextAnalyticsErrorInternal error)
            : base(completedOn, error)
        {
            _documentsResults = result;
        }

        /// <summary>
        /// Gets the result of the execution of an <see cref="ExtractKeyPhrasesAction"/> per each input document.
        /// </summary>
        public ExtractKeyPhrasesResultCollection DocumentsResults
        {
            get
            {
                if (HasError)
                {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations
                    throw new InvalidOperationException($"Cannot access the results of this action, due to error {Error.ErrorCode}: {Error.Message}");
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
                }
                return _documentsResults;
            }
        }
    }
}

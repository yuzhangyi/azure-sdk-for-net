// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Options for enabling automatic scaling on a pool.
    /// </summary>
    public partial class PoolEnableAutoScaleParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolEnableAutoScaleParameter
        /// class.
        /// </summary>
        public PoolEnableAutoScaleParameter() { }

        /// <summary>
        /// Initializes a new instance of the PoolEnableAutoScaleParameter
        /// class.
        /// </summary>
        /// <param name="autoScaleFormula">The formula for the desired number
        /// of compute nodes in the pool.</param>
        /// <param name="autoScaleEvaluationInterval">The time interval at
        /// which to automatically adjust the pool size according to the
        /// autoscale formula.</param>
        public PoolEnableAutoScaleParameter(string autoScaleFormula = default(string), System.TimeSpan? autoScaleEvaluationInterval = default(System.TimeSpan?))
        {
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
        }

        /// <summary>
        /// Gets or sets the formula for the desired number of compute nodes in
        /// the pool.
        /// </summary>
        /// <remarks>
        /// The formula is checked for validity before it is applied to the
        /// pool. If the formula is not valid, the Batch service rejects the
        /// request with detailed error information. For more information about
        /// specifying this formula, see Automatically scale compute nodes in
        /// an Azure Batch pool
        /// (https://azure.microsoft.com/en-us/documentation/articles/batch-automatic-scaling).
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoScaleFormula")]
        public string AutoScaleFormula { get; set; }

        /// <summary>
        /// Gets or sets the time interval at which to automatically adjust the
        /// pool size according to the autoscale formula.
        /// </summary>
        /// <remarks>
        /// The default value is 15 minutes. The minimum and maximum value are
        /// 5 minutes and 168 hours respectively. If you specify a value less
        /// than 5 minutes or greater than 168 hours, the Batch service rejects
        /// the request with an invalid property value error; if you are
        /// calling the REST API directly, the HTTP status code is 400 (Bad
        /// Request). If you specify a new interval, then the existing
        /// autoscale evaluation schedule will be stopped and a new autoscale
        /// evaluation schedule will be started, with its starting time being
        /// the time when this request was issued.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoScaleEvaluationInterval")]
        public System.TimeSpan? AutoScaleEvaluationInterval { get; set; }

    }
}
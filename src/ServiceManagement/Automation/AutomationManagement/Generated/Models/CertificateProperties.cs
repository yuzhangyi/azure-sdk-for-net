// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Automation.Models
{
    /// <summary>
    /// Properties of the certificate.
    /// </summary>
    public partial class CertificateProperties
    {
        private DateTimeOffset _creationTime;
        
        /// <summary>
        /// Optional. Gets or sets the creation time of the certificate.
        /// </summary>
        public DateTimeOffset CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the description of the certificate.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private DateTimeOffset _expiryTime;
        
        /// <summary>
        /// Optional. Gets or sets the expiry time of the certificate.
        /// </summary>
        public DateTimeOffset ExpiryTime
        {
            get { return this._expiryTime; }
            set { this._expiryTime = value; }
        }
        
        private bool _isExportable;
        
        /// <summary>
        /// Optional. Gets or sets the is exportable flag of the certificate.
        /// </summary>
        public bool IsExportable
        {
            get { return this._isExportable; }
            set { this._isExportable = value; }
        }
        
        private DateTimeOffset _lastModifiedTime;
        
        /// <summary>
        /// Optional. Gets or sets the last modified time of the certificate.
        /// </summary>
        public DateTimeOffset LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }
        
        private string _thumbprint;
        
        /// <summary>
        /// Optional. Gets or sets the thumbprint of the certificate.
        /// </summary>
        public string Thumbprint
        {
            get { return this._thumbprint; }
            set { this._thumbprint = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CertificateProperties class.
        /// </summary>
        public CertificateProperties()
        {
        }
    }
}
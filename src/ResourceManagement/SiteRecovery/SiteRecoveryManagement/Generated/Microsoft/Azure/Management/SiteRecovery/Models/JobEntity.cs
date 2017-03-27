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

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of job task object.
    /// </summary>
    public partial class JobEntity
    {
        private string _jobFriendlyName;
        
        /// <summary>
        /// Required. Job display name.
        /// </summary>
        public string JobFriendlyName
        {
            get { return this._jobFriendlyName; }
            set { this._jobFriendlyName = value; }
        }
        
        private string _jobId;
        
        /// <summary>
        /// Required. Job Id.
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }
        
        private string _jobScenarioName;
        
        /// <summary>
        /// Required. Job scenario name.
        /// </summary>
        public string JobScenarioName
        {
            get { return this._jobScenarioName; }
            set { this._jobScenarioName = value; }
        }
        
        private string _targetInstanceType;
        
        /// <summary>
        /// Required. Object type.
        /// </summary>
        public string TargetInstanceType
        {
            get { return this._targetInstanceType; }
            set { this._targetInstanceType = value; }
        }
        
        private string _targetObjectId;
        
        /// <summary>
        /// Required. Object Id.
        /// </summary>
        public string TargetObjectId
        {
            get { return this._targetObjectId; }
            set { this._targetObjectId = value; }
        }
        
        private string _targetObjectName;
        
        /// <summary>
        /// Required. Object name.
        /// </summary>
        public string TargetObjectName
        {
            get { return this._targetObjectName; }
            set { this._targetObjectName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobEntity class.
        /// </summary>
        public JobEntity()
        {
        }
    }
}
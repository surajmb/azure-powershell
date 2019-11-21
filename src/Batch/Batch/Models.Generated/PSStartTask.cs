﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSStartTask
    {
        
        internal Microsoft.Azure.Batch.StartTask omObject;
        
        private PSTaskContainerSettings containerSettings;
        
        private IDictionary environmentSettings;
        
        private IList<PSResourceFile> resourceFiles;
        
        private PSUserIdentity userIdentity;
        
        public PSStartTask()
        {
            this.omObject = new Microsoft.Azure.Batch.StartTask();
        }
        
        public PSStartTask(string commandLine)
        {
            this.omObject = new Microsoft.Azure.Batch.StartTask(commandLine);
        }
        
        internal PSStartTask(Microsoft.Azure.Batch.StartTask omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public string CommandLine
        {
            get
            {
                return this.omObject.CommandLine;
            }
            set
            {
                this.omObject.CommandLine = value;
            }
        }
        
        public PSTaskContainerSettings ContainerSettings
        {
            get
            {
                if (((this.containerSettings == null) 
                            && (this.omObject.ContainerSettings != null)))
                {
                    this.containerSettings = new PSTaskContainerSettings(this.omObject.ContainerSettings);
                }
                return this.containerSettings;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.ContainerSettings = null;
                }
                else
                {
                    this.omObject.ContainerSettings = value.omObject;
                }
                this.containerSettings = value;
            }
        }
        
        public IDictionary EnvironmentSettings
        {
            get
            {
                if (((this.environmentSettings == null) 
                            && (this.omObject.EnvironmentSettings != null)))
                {
                    Dictionary<string, string> dict;
                    dict = new Dictionary<string, string>();
                    IEnumerator<Microsoft.Azure.Batch.EnvironmentSetting> enumerator;
                    enumerator = this.omObject.EnvironmentSettings.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        dict.Add(enumerator.Current.Name, enumerator.Current.Value);
                    }
                    this.environmentSettings = dict;
                }
                return this.environmentSettings;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.EnvironmentSettings = null;
                }
                else
                {
                    this.omObject.EnvironmentSettings = new List<Microsoft.Azure.Batch.EnvironmentSetting>();
                }
                this.environmentSettings = value;
            }
        }
        
        public System.Int32? MaxTaskRetryCount
        {
            get
            {
                return this.omObject.MaxTaskRetryCount;
            }
            set
            {
                this.omObject.MaxTaskRetryCount = value;
            }
        }
        
        public IList<PSResourceFile> ResourceFiles
        {
            get
            {
                if (((this.resourceFiles == null) 
                            && (this.omObject.ResourceFiles != null)))
                {
                    List<PSResourceFile> list;
                    list = new List<PSResourceFile>();
                    IEnumerator<Microsoft.Azure.Batch.ResourceFile> enumerator;
                    enumerator = this.omObject.ResourceFiles.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSResourceFile(enumerator.Current));
                    }
                    this.resourceFiles = list;
                }
                return this.resourceFiles;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.ResourceFiles = null;
                }
                else
                {
                    this.omObject.ResourceFiles = new List<Microsoft.Azure.Batch.ResourceFile>();
                }
                this.resourceFiles = value;
            }
        }
        
        public PSUserIdentity UserIdentity
        {
            get
            {
                if (((this.userIdentity == null) 
                            && (this.omObject.UserIdentity != null)))
                {
                    this.userIdentity = new PSUserIdentity(this.omObject.UserIdentity);
                }
                return this.userIdentity;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.UserIdentity = null;
                }
                else
                {
                    this.omObject.UserIdentity = value.omObject;
                }
                this.userIdentity = value;
            }
        }
        
        public System.Boolean? WaitForSuccess
        {
            get
            {
                return this.omObject.WaitForSuccess;
            }
            set
            {
                this.omObject.WaitForSuccess = value;
            }
        }
    }
}
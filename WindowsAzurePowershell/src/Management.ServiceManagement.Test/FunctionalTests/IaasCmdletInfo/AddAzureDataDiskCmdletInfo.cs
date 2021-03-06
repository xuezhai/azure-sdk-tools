﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.IaasCmdletInfo
{
    using Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.ConfigDataInfo;
    using Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.PowershellCore;
    
    public class AddAzureDataDiskCmdletInfo : CmdletsInfo
    {
        public AddAzureDataDiskCmdletInfo(AddAzureDataDiskConfig diskConfig)
        {
            this.cmdletName = Utilities.AddAzureDataDiskCmdletName;
            
            //this.cmdletParams.Add(new CmdletParam(diskConfig.DiskCreateOption.ToString(), null));
            this.cmdletParams.Add(new CmdletParam("CreateNew", null));
            this.cmdletParams.Add(new CmdletParam("DiskSizeInGB", diskConfig.DiskSizeGB));
            this.cmdletParams.Add(new CmdletParam("DiskLabel", diskConfig.DiskLabel));
            this.cmdletParams.Add(new CmdletParam("LUN", diskConfig.LunSlot));
            this.cmdletParams.Add(new CmdletParam("VM", diskConfig.Vm));
        }
    }
}

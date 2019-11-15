/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class StopMixStreamsServiceRequest : RpcAcsRequest<StopMixStreamsServiceResponse>
    {
        public StopMixStreamsServiceRequest()
            : base("Cdn", "2014-11-11", "StopMixStreamsService")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string mixStreamName;

		private string mixAppName;

		private string mainStreamName;

		private string securityToken;

		private string mainDomainName;

		private string mixDomainName;

		private long? ownerId;

		private string mainAppName;

		public string MixStreamName
		{
			get
			{
				return mixStreamName;
			}
			set	
			{
				mixStreamName = value;
				DictionaryUtil.Add(QueryParameters, "MixStreamName", value);
			}
		}

		public string MixAppName
		{
			get
			{
				return mixAppName;
			}
			set	
			{
				mixAppName = value;
				DictionaryUtil.Add(QueryParameters, "MixAppName", value);
			}
		}

		public string MainStreamName
		{
			get
			{
				return mainStreamName;
			}
			set	
			{
				mainStreamName = value;
				DictionaryUtil.Add(QueryParameters, "MainStreamName", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string MainDomainName
		{
			get
			{
				return mainDomainName;
			}
			set	
			{
				mainDomainName = value;
				DictionaryUtil.Add(QueryParameters, "MainDomainName", value);
			}
		}

		public string MixDomainName
		{
			get
			{
				return mixDomainName;
			}
			set	
			{
				mixDomainName = value;
				DictionaryUtil.Add(QueryParameters, "MixDomainName", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string MainAppName
		{
			get
			{
				return mainAppName;
			}
			set	
			{
				mainAppName = value;
				DictionaryUtil.Add(QueryParameters, "MainAppName", value);
			}
		}

        public override StopMixStreamsServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StopMixStreamsServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

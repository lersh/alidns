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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Alidns.Model.V20150109;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDnsProductInstancesResponseUnmarshaller
    {
        public static DescribeDnsProductInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDnsProductInstancesResponse describeDnsProductInstancesResponse = new DescribeDnsProductInstancesResponse();

			describeDnsProductInstancesResponse.HttpResponse = context.HttpResponse;
			describeDnsProductInstancesResponse.RequestId = context.StringValue("DescribeDnsProductInstances.RequestId");
			describeDnsProductInstancesResponse.TotalCount = context.LongValue("DescribeDnsProductInstances.TotalCount");
			describeDnsProductInstancesResponse.PageNumber = context.LongValue("DescribeDnsProductInstances.PageNumber");
			describeDnsProductInstancesResponse.PageSize = context.LongValue("DescribeDnsProductInstances.PageSize");

			List<DescribeDnsProductInstancesResponse.DnsProduct> dnsProducts = new List<DescribeDnsProductInstancesResponse.DnsProduct>();
			for (int i = 0; i < context.Length("DescribeDnsProductInstances.DnsProducts.Length"); i++) {
				DescribeDnsProductInstancesResponse.DnsProduct dnsProduct = new DescribeDnsProductInstancesResponse.DnsProduct();
				dnsProduct.InstanceId = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].InstanceId");
				dnsProduct.VersionCode = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].VersionCode");
				dnsProduct.VersionName = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].VersionName");
				dnsProduct.StartTime = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].StartTime");
				dnsProduct.EndTime = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].EndTime");
				dnsProduct.Domain = context.StringValue("DescribeDnsProductInstances.DnsProducts["+ i +"].Domain");

				dnsProducts.Add(dnsProduct);
			}
			describeDnsProductInstancesResponse.DnsProducts = dnsProducts;
        
			return describeDnsProductInstancesResponse;
        }
    }
}
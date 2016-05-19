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
    public class DescribeDnsProductAttributesResponseUnmarshaller
    {
        public static DescribeDnsProductAttributesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDnsProductAttributesResponse describeDnsProductAttributesResponse = new DescribeDnsProductAttributesResponse();

			describeDnsProductAttributesResponse.HttpResponse = context.HttpResponse;
			describeDnsProductAttributesResponse.RequestId = context.StringValue("DescribeDnsProductAttributes.RequestId");
			describeDnsProductAttributesResponse.TtlMinValue = context.StringValue("DescribeDnsProductAttributes.TtlMinValue");
			describeDnsProductAttributesResponse.TtlMaxValue = context.StringValue("DescribeDnsProductAttributes.TtlMaxValue");

			List<string> recordTypes = new List<string>();
			for (int i = 0; i < context.Length("DescribeDnsProductAttributes.RecordTypes.Length"); i++) {
				recordTypes.Add(context.StringValue("DescribeDnsProductAttributes.RecordTypes["+ i +"]"));
			}
			describeDnsProductAttributesResponse.RecordTypes = recordTypes;

			List<DescribeDnsProductAttributesResponse.RecordLine> recordLines = new List<DescribeDnsProductAttributesResponse.RecordLine>();
			for (int i = 0; i < context.Length("DescribeDnsProductAttributes.RecordLines.Length"); i++) {
				DescribeDnsProductAttributesResponse.RecordLine recordLine = new DescribeDnsProductAttributesResponse.RecordLine();
				recordLine.LineCode = context.StringValue("DescribeDnsProductAttributes.RecordLines["+ i +"].LineCode");
				recordLine.FatherCode = context.StringValue("DescribeDnsProductAttributes.RecordLines["+ i +"].FatherCode");
				recordLine.LineName = context.StringValue("DescribeDnsProductAttributes.RecordLines["+ i +"].LineName");

				recordLines.Add(recordLine);
			}
			describeDnsProductAttributesResponse.RecordLines = recordLines;
        
			return describeDnsProductAttributesResponse;
        }
    }
}
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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDnsProductAttributesResponse : AcsResponse
	{

		private string ttlMinValue;

		private string ttlMaxValue;

		private List<RecordLine> recordLines;

		private List<string> recordTypes;

		public string TtlMinValue
		{
			get
			{
				return ttlMinValue;
			}
			set	
			{
				ttlMinValue = value;
			}
		}

		public string TtlMaxValue
		{
			get
			{
				return ttlMaxValue;
			}
			set	
			{
				ttlMaxValue = value;
			}
		}

		public List<RecordLine> RecordLines
		{
			get
			{
				return recordLines;
			}
			set	
			{
				recordLines = value;
			}
		}

		public List<string> RecordTypes
		{
			get
			{
				return recordTypes;
			}
			set	
			{
				recordTypes = value;
			}
		}

		public class RecordLine{

			private string lineCode;

			private string fatherCode;

			private string lineName;

			public string LineCode
			{
				get
				{
					return lineCode;
				}
				set	
				{
					lineCode = value;
				}
			}

			public string FatherCode
			{
				get
				{
					return fatherCode;
				}
				set	
				{
					fatherCode = value;
				}
			}

			public string LineName
			{
				get
				{
					return lineName;
				}
				set	
				{
					lineName = value;
				}
			}
		}
	}
}
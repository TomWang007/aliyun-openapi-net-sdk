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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class DescribeStreamPredictResultResponseUnmarshaller
    {
        public static DescribeStreamPredictResultResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStreamPredictResultResponse describeStreamPredictResultResponse = new DescribeStreamPredictResultResponse();

			describeStreamPredictResultResponse.HttpResponse = context.HttpResponse;
			describeStreamPredictResultResponse.RequestId = context.StringValue("DescribeStreamPredictResult.RequestId");
			describeStreamPredictResultResponse.TotalNum = context.LongValue("DescribeStreamPredictResult.TotalNum");
			describeStreamPredictResultResponse.CurrentPage = context.LongValue("DescribeStreamPredictResult.CurrentPage");
			describeStreamPredictResultResponse.PageSize = context.LongValue("DescribeStreamPredictResult.PageSize");
			describeStreamPredictResultResponse.NextPageToken = context.StringValue("DescribeStreamPredictResult.NextPageToken");

			List<DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData> describeStreamPredictResultResponse_streamPredictDatas = new List<DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData>();
			for (int i = 0; i < context.Length("DescribeStreamPredictResult.StreamPredictDatas.Length"); i++) {
				DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData streamPredictData = new DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData();
				streamPredictData.PredictId = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictId");
				streamPredictData.ModelId = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].ModelId");
				streamPredictData.DataUrl = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].DataUrl");
				streamPredictData.Timestamp = context.LongValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].Timestamp");
				streamPredictData.PredictTime = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictTime");
				streamPredictData.Status = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].Status");
				streamPredictData.PredictResult = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictResult");

				describeStreamPredictResultResponse_streamPredictDatas.Add(streamPredictData);
			}
			describeStreamPredictResultResponse.StreamPredictDatas = describeStreamPredictResultResponse_streamPredictDatas;
        
			return describeStreamPredictResultResponse;
        }
    }
}

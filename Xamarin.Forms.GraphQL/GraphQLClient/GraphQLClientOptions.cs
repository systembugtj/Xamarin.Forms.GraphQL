﻿// MIT License
//   
// Copyright(c) 2017 graphql-dotnet
// Copyright(c) 2018 Microsoft
//   
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Xamarin.Forms.GraphQL.Client
{
	public class GraphQLClientOptions
	{
		public GraphQLClientOptions(Uri endPoint, JsonSerializerSettings jsonSerializerSettings = null, HttpMessageHandler httpMessageHandler = null, MediaTypeHeaderValue mediaTypeHeaderValue = null)
		{
			EndPoint = endPoint ?? throw new ArgumentNullException(nameof(endPoint));
			JsonSerializerSettings = jsonSerializerSettings ?? new JsonSerializerSettings {
				ContractResolver = new CamelCasePropertyNamesContractResolver()
			};
			HttpMessageHandler = httpMessageHandler ?? new HttpClientHandler();
			MediaTypeHeaderValue = mediaTypeHeaderValue ?? new MediaTypeHeaderValue("application/json");

		}

		public Uri EndPoint { get; }
		public JsonSerializerSettings JsonSerializerSettings { get; }
		public HttpMessageHandler HttpMessageHandler { get; }
		public MediaTypeHeaderValue MediaTypeHeaderValue { get; }
	}
}
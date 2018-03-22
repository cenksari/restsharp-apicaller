namespace Api
{
	using RestSharp;
	using System;
	using System.Threading;
	using System.Threading.Tasks;

	public class ApiCaller
	{
		string apiAddress, authentication;

		public ApiCaller()
		{
			apiAddress = "https://www.google.com";
			authentication = "3699be21-09c8-4fa1-b2ad-9841d31c30af";
		}

		public async Task<RestResponse> GetEndpoint(RestRequest apiRequest)
		{
			RestResponse returnedValue = new RestResponse();

			RestClient client = new RestClient();

			client.BaseUrl = new Uri(apiAddress);

			RestSharp.RestRequest request = new RestSharp.RestRequest(apiRequest.Endpoint);

			request.AddHeader("Authentication", authentication);

			request.Method = (apiRequest.Method == "POST") ? Method.POST : Method.GET;

			if (apiRequest.Parameters != null)
			{
				foreach (RestParameter parameter in apiRequest.Parameters)
				{
					request.AddParameter
					(
						parameter.Name,
						parameter.Value
					);
				}
			}

			var cancellationTokenSource = new CancellationTokenSource();

			var response = await client.ExecuteTaskAsync
			(
				request,
				cancellationTokenSource.Token
			);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				returnedValue.Status = true;
				returnedValue.Response = response.Content;
			}
			else
			{
				returnedValue.Status = false;
				returnedValue.Message = $"{response.StatusDescription} {response.ErrorMessage}";
				returnedValue.Response = response.Content;
				returnedValue.ErrorCode = response.StatusCode.ToString();
			}

			return returnedValue;
		}
	}
}
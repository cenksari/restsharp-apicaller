namespace Api
{
	using System.Collections.Generic;

	public class RestResponse
	{
		public bool Status { get; set; }
		public string Message { get; set; }
		public string Response { get; set; }
		public string ErrorCode { get; set; }
	}

	public class RestRequest
	{
		public string Method { get; set; }
		public string Endpoint { get; set; }
		public List<RestParameter> Parameters { get; set; }
	}

	public class RestParameter
	{
		public string Name { get; set; }
		public string Value { get; set; }
	}
}
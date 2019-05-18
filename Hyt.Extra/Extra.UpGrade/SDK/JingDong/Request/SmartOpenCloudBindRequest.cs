using System;
using System.Collections.Generic;
using Extra.UpGrade.SDK.JingDong.Response;
using Extra.UpGrade.SDK.JingDong.Util;

namespace Extra.UpGrade.SDK.JingDong.Request
{
public class SmartOpenCloudBindRequest : IJdRequest<SmartOpenCloudBindResponse>
{
		                                                                      
public   		Nullable<long>
   feedId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   accessKey  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   deviceName  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   jdUid  { get; set; }

                  
                                                                                                                                    
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.smart.open.cloudBind";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("feed_id", this.feedId);
			parameters.Add("access_key", this.accessKey);
			parameters.Add("device_name", this.deviceName);
			parameters.Add("jd_uid", this.jdUid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
        }

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new JdDictionary();
            }
            this.otherParameters.Add(key, value);
        }

}
}








        
 

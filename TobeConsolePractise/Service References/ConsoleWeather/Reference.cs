﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TobeConsolePractise.ConsoleWeather {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Choice", Namespace="http://tempuri.org/")]
    public enum Choice : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Abia = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Abuja = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Anambra = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Lagos = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Time", Namespace="http://tempuri.org/")]
    public enum Time : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Two = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Four = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Six = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Eight = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ten = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConsoleWeather.AsyncServiceSoap")]
    public interface AsyncServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetWeatherResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWeather", ReplyAction="*")]
        TobeConsolePractise.ConsoleWeather.GetWeatherResponse GetWeather(TobeConsolePractise.ConsoleWeather.GetWeatherRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWeather", ReplyAction="*")]
        System.Threading.Tasks.Task<TobeConsolePractise.ConsoleWeather.GetWeatherResponse> GetWeatherAsync(TobeConsolePractise.ConsoleWeather.GetWeatherRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b, int delayInSecs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b, int delayInSecs);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWeatherRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWeather", Namespace="http://tempuri.org/", Order=0)]
        public TobeConsolePractise.ConsoleWeather.GetWeatherRequestBody Body;
        
        public GetWeatherRequest() {
        }
        
        public GetWeatherRequest(TobeConsolePractise.ConsoleWeather.GetWeatherRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWeatherRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public TobeConsolePractise.ConsoleWeather.Choice ch;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public TobeConsolePractise.ConsoleWeather.Time t;
        
        public GetWeatherRequestBody() {
        }
        
        public GetWeatherRequestBody(TobeConsolePractise.ConsoleWeather.Choice ch, TobeConsolePractise.ConsoleWeather.Time t) {
            this.ch = ch;
            this.t = t;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWeatherResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWeatherResponse", Namespace="http://tempuri.org/", Order=0)]
        public TobeConsolePractise.ConsoleWeather.GetWeatherResponseBody Body;
        
        public GetWeatherResponse() {
        }
        
        public GetWeatherResponse(TobeConsolePractise.ConsoleWeather.GetWeatherResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWeatherResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetWeatherResult;
        
        public GetWeatherResponseBody() {
        }
        
        public GetWeatherResponseBody(string GetWeatherResult) {
            this.GetWeatherResult = GetWeatherResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AsyncServiceSoapChannel : TobeConsolePractise.ConsoleWeather.AsyncServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AsyncServiceSoapClient : System.ServiceModel.ClientBase<TobeConsolePractise.ConsoleWeather.AsyncServiceSoap>, TobeConsolePractise.ConsoleWeather.AsyncServiceSoap {
        
        public AsyncServiceSoapClient() {
        }
        
        public AsyncServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AsyncServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsyncServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsyncServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TobeConsolePractise.ConsoleWeather.GetWeatherResponse TobeConsolePractise.ConsoleWeather.AsyncServiceSoap.GetWeather(TobeConsolePractise.ConsoleWeather.GetWeatherRequest request) {
            return base.Channel.GetWeather(request);
        }
        
        public string GetWeather(TobeConsolePractise.ConsoleWeather.Choice ch, TobeConsolePractise.ConsoleWeather.Time t) {
            TobeConsolePractise.ConsoleWeather.GetWeatherRequest inValue = new TobeConsolePractise.ConsoleWeather.GetWeatherRequest();
            inValue.Body = new TobeConsolePractise.ConsoleWeather.GetWeatherRequestBody();
            inValue.Body.ch = ch;
            inValue.Body.t = t;
            TobeConsolePractise.ConsoleWeather.GetWeatherResponse retVal = ((TobeConsolePractise.ConsoleWeather.AsyncServiceSoap)(this)).GetWeather(inValue);
            return retVal.Body.GetWeatherResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TobeConsolePractise.ConsoleWeather.GetWeatherResponse> TobeConsolePractise.ConsoleWeather.AsyncServiceSoap.GetWeatherAsync(TobeConsolePractise.ConsoleWeather.GetWeatherRequest request) {
            return base.Channel.GetWeatherAsync(request);
        }
        
        public System.Threading.Tasks.Task<TobeConsolePractise.ConsoleWeather.GetWeatherResponse> GetWeatherAsync(TobeConsolePractise.ConsoleWeather.Choice ch, TobeConsolePractise.ConsoleWeather.Time t) {
            TobeConsolePractise.ConsoleWeather.GetWeatherRequest inValue = new TobeConsolePractise.ConsoleWeather.GetWeatherRequest();
            inValue.Body = new TobeConsolePractise.ConsoleWeather.GetWeatherRequestBody();
            inValue.Body.ch = ch;
            inValue.Body.t = t;
            return ((TobeConsolePractise.ConsoleWeather.AsyncServiceSoap)(this)).GetWeatherAsync(inValue);
        }
        
        public int Add(int a, int b, int delayInSecs) {
            return base.Channel.Add(a, b, delayInSecs);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b, int delayInSecs) {
            return base.Channel.AddAsync(a, b, delayInSecs);
        }
    }
}
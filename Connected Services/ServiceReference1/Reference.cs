//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.servicios.co/pagos/service", ConfigurationName="ServiceReference1.PagosInerface")]
    public interface PagosInerface
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="consultar", ReplyAction="http://www.servicios.co/pagos/service/PagosInerface/CosultarResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.CosultarResponse> CosultarAsync(ServiceReference1.CosultarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="pagar", ReplyAction="http://www.servicios.co/pagos/service/PagosInerface/PagarResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.PagarResponse> PagarAsync(ServiceReference1.PagarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="compensar", ReplyAction="http://www.servicios.co/pagos/service/PagosInerface/CompensarResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.CompensarResponse> CompensarAsync(ServiceReference1.CompensarRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.servicios.co/pagos/schemas")]
    public partial class ReferenciaFactura
    {
        
        private string referenciaFacturaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string referenciaFactura
        {
            get
            {
                return this.referenciaFacturaField;
            }
            set
            {
                this.referenciaFacturaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.servicios.co/pagos/schemas")]
    public partial class Resultado
    {
        
        private ReferenciaFactura referenciaFacturaField;
        
        private string mensajeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenciaFactura referenciaFactura
        {
            get
            {
                return this.referenciaFacturaField;
            }
            set
            {
                this.referenciaFacturaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string mensaje
        {
            get
            {
                return this.mensajeField;
            }
            set
            {
                this.mensajeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.servicios.co/pagos/schemas")]
    public partial class Pago
    {
        
        private ReferenciaFactura referenciaFacturaField;
        
        private double totalPagarField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenciaFactura referenciaFactura
        {
            get
            {
                return this.referenciaFacturaField;
            }
            set
            {
                this.referenciaFacturaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double totalPagar
        {
            get
            {
                return this.totalPagarField;
            }
            set
            {
                this.totalPagarField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.servicios.co/pagos/schemas")]
    public partial class ResultadoConsulta
    {
        
        private ReferenciaFactura referenciaFacturaField;
        
        private double totalPagarField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenciaFactura referenciaFactura
        {
            get
            {
                return this.referenciaFacturaField;
            }
            set
            {
                this.referenciaFacturaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double totalPagar
        {
            get
            {
                return this.totalPagarField;
            }
            set
            {
                this.totalPagarField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CosultarRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.servicios.co/pagos/schemas", Order=0)]
        public ServiceReference1.ReferenciaFactura ReferenciaFactura;
        
        public CosultarRequest()
        {
        }
        
        public CosultarRequest(ServiceReference1.ReferenciaFactura ReferenciaFactura)
        {
            this.ReferenciaFactura = ReferenciaFactura;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CosultarResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.servicios.co/pagos/schemas", Order=0)]
        public ServiceReference1.ResultadoConsulta ResultadoConsulta;
        
        public CosultarResponse()
        {
        }
        
        public CosultarResponse(ServiceReference1.ResultadoConsulta ResultadoConsulta)
        {
            this.ResultadoConsulta = ResultadoConsulta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PagarRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.servicios.co/pagos/schemas", Order=0)]
        public ServiceReference1.Pago Pago;
        
        public PagarRequest()
        {
        }
        
        public PagarRequest(ServiceReference1.Pago Pago)
        {
            this.Pago = Pago;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PagarResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.servicios.co/pagos/schemas", Order=0)]
        public ServiceReference1.Resultado Resultado;
        
        public PagarResponse()
        {
        }
        
        public PagarResponse(ServiceReference1.Resultado Resultado)
        {
            this.Resultado = Resultado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompensarRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.servicios.co/pagos/schemas", Order=0)]
        public ServiceReference1.Pago Pago;
        
        public CompensarRequest()
        {
        }
        
        public CompensarRequest(ServiceReference1.Pago Pago)
        {
            this.Pago = Pago;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompensarResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.servicios.co/pagos/schemas", Order=0)]
        public ServiceReference1.Resultado Resultado;
        
        public CompensarResponse()
        {
        }
        
        public CompensarResponse(ServiceReference1.Resultado Resultado)
        {
            this.Resultado = Resultado;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface PagosInerfaceChannel : ServiceReference1.PagosInerface, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class PagosInerfaceClient : System.ServiceModel.ClientBase<ServiceReference1.PagosInerface>, ServiceReference1.PagosInerface
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PagosInerfaceClient() : 
                base(PagosInerfaceClient.GetDefaultBinding(), PagosInerfaceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.PagosServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PagosInerfaceClient(EndpointConfiguration endpointConfiguration) : 
                base(PagosInerfaceClient.GetBindingForEndpoint(endpointConfiguration), PagosInerfaceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PagosInerfaceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PagosInerfaceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PagosInerfaceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PagosInerfaceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PagosInerfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.CosultarResponse> ServiceReference1.PagosInerface.CosultarAsync(ServiceReference1.CosultarRequest request)
        {
            return base.Channel.CosultarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CosultarResponse> CosultarAsync(ServiceReference1.ReferenciaFactura ReferenciaFactura)
        {
            ServiceReference1.CosultarRequest inValue = new ServiceReference1.CosultarRequest();
            inValue.ReferenciaFactura = ReferenciaFactura;
            return ((ServiceReference1.PagosInerface)(this)).CosultarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.PagarResponse> ServiceReference1.PagosInerface.PagarAsync(ServiceReference1.PagarRequest request)
        {
            return base.Channel.PagarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.PagarResponse> PagarAsync(ServiceReference1.Pago Pago)
        {
            ServiceReference1.PagarRequest inValue = new ServiceReference1.PagarRequest();
            inValue.Pago = Pago;
            return ((ServiceReference1.PagosInerface)(this)).PagarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.CompensarResponse> ServiceReference1.PagosInerface.CompensarAsync(ServiceReference1.CompensarRequest request)
        {
            return base.Channel.CompensarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CompensarResponse> CompensarAsync(ServiceReference1.Pago Pago)
        {
            ServiceReference1.CompensarRequest inValue = new ServiceReference1.CompensarRequest();
            inValue.Pago = Pago;
            return ((ServiceReference1.PagosInerface)(this)).CompensarAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PagosServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PagosServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://35.185.30.69:7070/w1-soap-svr/PagosServiceService");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PagosInerfaceClient.GetBindingForEndpoint(EndpointConfiguration.PagosServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PagosInerfaceClient.GetEndpointAddress(EndpointConfiguration.PagosServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            PagosServicePort,
        }
    }
}

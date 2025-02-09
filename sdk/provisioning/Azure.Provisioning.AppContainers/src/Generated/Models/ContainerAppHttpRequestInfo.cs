// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// HTTPGet specifies the http request to perform.
/// </summary>
public partial class ContainerAppHttpRequestInfo : ProvisionableConstruct
{
    /// <summary>
    /// Host name to connect to, defaults to the pod IP. You probably want to
    /// set &quot;Host&quot; in httpHeaders instead.
    /// </summary>
    public BicepValue<string> Host 
    {
        get { Initialize(); return _host!; }
        set { Initialize(); _host!.Assign(value); }
    }
    private BicepValue<string>? _host;

    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers.
    /// </summary>
    public BicepList<ContainerAppHttpHeaderInfo> HttpHeaders 
    {
        get { Initialize(); return _httpHeaders!; }
        set { Initialize(); _httpHeaders!.Assign(value); }
    }
    private BicepList<ContainerAppHttpHeaderInfo>? _httpHeaders;

    /// <summary>
    /// Path to access on the HTTP server.
    /// </summary>
    public BicepValue<string> Path 
    {
        get { Initialize(); return _path!; }
        set { Initialize(); _path!.Assign(value); }
    }
    private BicepValue<string>? _path;

    /// <summary>
    /// Name or number of the port to access on the container. Number must be
    /// in the range 1 to 65535. Name must be an IANA_SVC_NAME.
    /// </summary>
    public BicepValue<int> Port 
    {
        get { Initialize(); return _port!; }
        set { Initialize(); _port!.Assign(value); }
    }
    private BicepValue<int>? _port;

    /// <summary>
    /// Scheme to use for connecting to the host. Defaults to HTTP.
    /// </summary>
    public BicepValue<ContainerAppHttpScheme> Scheme 
    {
        get { Initialize(); return _scheme!; }
        set { Initialize(); _scheme!.Assign(value); }
    }
    private BicepValue<ContainerAppHttpScheme>? _scheme;

    /// <summary>
    /// Creates a new ContainerAppHttpRequestInfo.
    /// </summary>
    public ContainerAppHttpRequestInfo()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerAppHttpRequestInfo.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _host = DefineProperty<string>("Host", ["host"]);
        _httpHeaders = DefineListProperty<ContainerAppHttpHeaderInfo>("HttpHeaders", ["httpHeaders"]);
        _path = DefineProperty<string>("Path", ["path"]);
        _port = DefineProperty<int>("Port", ["port"]);
        _scheme = DefineProperty<ContainerAppHttpScheme>("Scheme", ["scheme"]);
    }
}

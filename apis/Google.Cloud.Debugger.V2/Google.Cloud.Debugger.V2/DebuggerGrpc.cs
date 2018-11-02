// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/clouddebugger/v2/debugger.proto
// </auto-generated>
// Original file comments:
// Copyright 2018 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Debugger.V2 {
  /// <summary>
  /// The Debugger service provides the API that allows users to collect run-time
  /// information from a running application, without stopping or slowing it down
  /// and without modifying its state.  An application may include one or
  /// more replicated processes performing the same work.
  ///
  /// A debugged application is represented using the Debuggee concept. The
  /// Debugger service provides a way to query for available debuggees, but does
  /// not provide a way to create one.  A debuggee is created using the Controller
  /// service, usually by running a debugger agent with the application.
  ///
  /// The Debugger service enables the client to set one or more Breakpoints on a
  /// Debuggee and collect the results of the set Breakpoints.
  /// </summary>
  public static partial class Debugger2
  {
    static readonly string __ServiceName = "google.devtools.clouddebugger.v2.Debugger2";

    static readonly grpc::Marshaller<global::Google.Cloud.Debugger.V2.SetBreakpointRequest> __Marshaller_SetBreakpointRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Debugger.V2.SetBreakpointRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Debugger.V2.SetBreakpointResponse> __Marshaller_SetBreakpointResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Debugger.V2.SetBreakpointResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Debugger.V2.GetBreakpointRequest> __Marshaller_GetBreakpointRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Debugger.V2.GetBreakpointRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Debugger.V2.GetBreakpointResponse> __Marshaller_GetBreakpointResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Debugger.V2.GetBreakpointResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Debugger.V2.DeleteBreakpointRequest> __Marshaller_DeleteBreakpointRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Debugger.V2.DeleteBreakpointRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Debugger.V2.ListBreakpointsRequest> __Marshaller_ListBreakpointsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Debugger.V2.ListBreakpointsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Debugger.V2.ListBreakpointsResponse> __Marshaller_ListBreakpointsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Debugger.V2.ListBreakpointsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Debugger.V2.ListDebuggeesRequest> __Marshaller_ListDebuggeesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Debugger.V2.ListDebuggeesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Debugger.V2.ListDebuggeesResponse> __Marshaller_ListDebuggeesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Debugger.V2.ListDebuggeesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Debugger.V2.SetBreakpointRequest, global::Google.Cloud.Debugger.V2.SetBreakpointResponse> __Method_SetBreakpoint = new grpc::Method<global::Google.Cloud.Debugger.V2.SetBreakpointRequest, global::Google.Cloud.Debugger.V2.SetBreakpointResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetBreakpoint",
        __Marshaller_SetBreakpointRequest,
        __Marshaller_SetBreakpointResponse);

    static readonly grpc::Method<global::Google.Cloud.Debugger.V2.GetBreakpointRequest, global::Google.Cloud.Debugger.V2.GetBreakpointResponse> __Method_GetBreakpoint = new grpc::Method<global::Google.Cloud.Debugger.V2.GetBreakpointRequest, global::Google.Cloud.Debugger.V2.GetBreakpointResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBreakpoint",
        __Marshaller_GetBreakpointRequest,
        __Marshaller_GetBreakpointResponse);

    static readonly grpc::Method<global::Google.Cloud.Debugger.V2.DeleteBreakpointRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteBreakpoint = new grpc::Method<global::Google.Cloud.Debugger.V2.DeleteBreakpointRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBreakpoint",
        __Marshaller_DeleteBreakpointRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::Google.Cloud.Debugger.V2.ListBreakpointsRequest, global::Google.Cloud.Debugger.V2.ListBreakpointsResponse> __Method_ListBreakpoints = new grpc::Method<global::Google.Cloud.Debugger.V2.ListBreakpointsRequest, global::Google.Cloud.Debugger.V2.ListBreakpointsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListBreakpoints",
        __Marshaller_ListBreakpointsRequest,
        __Marshaller_ListBreakpointsResponse);

    static readonly grpc::Method<global::Google.Cloud.Debugger.V2.ListDebuggeesRequest, global::Google.Cloud.Debugger.V2.ListDebuggeesResponse> __Method_ListDebuggees = new grpc::Method<global::Google.Cloud.Debugger.V2.ListDebuggeesRequest, global::Google.Cloud.Debugger.V2.ListDebuggeesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListDebuggees",
        __Marshaller_ListDebuggeesRequest,
        __Marshaller_ListDebuggeesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Debugger.V2.DebuggerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Debugger2</summary>
    public abstract partial class Debugger2Base
    {
      /// <summary>
      /// Sets the breakpoint to the debuggee.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Debugger.V2.SetBreakpointResponse> SetBreakpoint(global::Google.Cloud.Debugger.V2.SetBreakpointRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets breakpoint information.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Debugger.V2.GetBreakpointResponse> GetBreakpoint(global::Google.Cloud.Debugger.V2.GetBreakpointRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the breakpoint from the debuggee.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteBreakpoint(global::Google.Cloud.Debugger.V2.DeleteBreakpointRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists all breakpoints for the debuggee.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Debugger.V2.ListBreakpointsResponse> ListBreakpoints(global::Google.Cloud.Debugger.V2.ListBreakpointsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists all the debuggees that the user has access to.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Debugger.V2.ListDebuggeesResponse> ListDebuggees(global::Google.Cloud.Debugger.V2.ListDebuggeesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Debugger2</summary>
    public partial class Debugger2Client : grpc::ClientBase<Debugger2Client>
    {
      /// <summary>Creates a new client for Debugger2</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public Debugger2Client(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Debugger2 that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public Debugger2Client(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected Debugger2Client() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected Debugger2Client(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sets the breakpoint to the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Debugger.V2.SetBreakpointResponse SetBreakpoint(global::Google.Cloud.Debugger.V2.SetBreakpointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetBreakpoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sets the breakpoint to the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Debugger.V2.SetBreakpointResponse SetBreakpoint(global::Google.Cloud.Debugger.V2.SetBreakpointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetBreakpoint, null, options, request);
      }
      /// <summary>
      /// Sets the breakpoint to the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Debugger.V2.SetBreakpointResponse> SetBreakpointAsync(global::Google.Cloud.Debugger.V2.SetBreakpointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetBreakpointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sets the breakpoint to the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Debugger.V2.SetBreakpointResponse> SetBreakpointAsync(global::Google.Cloud.Debugger.V2.SetBreakpointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetBreakpoint, null, options, request);
      }
      /// <summary>
      /// Gets breakpoint information.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Debugger.V2.GetBreakpointResponse GetBreakpoint(global::Google.Cloud.Debugger.V2.GetBreakpointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBreakpoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets breakpoint information.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Debugger.V2.GetBreakpointResponse GetBreakpoint(global::Google.Cloud.Debugger.V2.GetBreakpointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBreakpoint, null, options, request);
      }
      /// <summary>
      /// Gets breakpoint information.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Debugger.V2.GetBreakpointResponse> GetBreakpointAsync(global::Google.Cloud.Debugger.V2.GetBreakpointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBreakpointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets breakpoint information.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Debugger.V2.GetBreakpointResponse> GetBreakpointAsync(global::Google.Cloud.Debugger.V2.GetBreakpointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBreakpoint, null, options, request);
      }
      /// <summary>
      /// Deletes the breakpoint from the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteBreakpoint(global::Google.Cloud.Debugger.V2.DeleteBreakpointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteBreakpoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the breakpoint from the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteBreakpoint(global::Google.Cloud.Debugger.V2.DeleteBreakpointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteBreakpoint, null, options, request);
      }
      /// <summary>
      /// Deletes the breakpoint from the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteBreakpointAsync(global::Google.Cloud.Debugger.V2.DeleteBreakpointRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteBreakpointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the breakpoint from the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteBreakpointAsync(global::Google.Cloud.Debugger.V2.DeleteBreakpointRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteBreakpoint, null, options, request);
      }
      /// <summary>
      /// Lists all breakpoints for the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Debugger.V2.ListBreakpointsResponse ListBreakpoints(global::Google.Cloud.Debugger.V2.ListBreakpointsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListBreakpoints(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all breakpoints for the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Debugger.V2.ListBreakpointsResponse ListBreakpoints(global::Google.Cloud.Debugger.V2.ListBreakpointsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListBreakpoints, null, options, request);
      }
      /// <summary>
      /// Lists all breakpoints for the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Debugger.V2.ListBreakpointsResponse> ListBreakpointsAsync(global::Google.Cloud.Debugger.V2.ListBreakpointsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListBreakpointsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all breakpoints for the debuggee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Debugger.V2.ListBreakpointsResponse> ListBreakpointsAsync(global::Google.Cloud.Debugger.V2.ListBreakpointsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListBreakpoints, null, options, request);
      }
      /// <summary>
      /// Lists all the debuggees that the user has access to.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Debugger.V2.ListDebuggeesResponse ListDebuggees(global::Google.Cloud.Debugger.V2.ListDebuggeesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDebuggees(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all the debuggees that the user has access to.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Debugger.V2.ListDebuggeesResponse ListDebuggees(global::Google.Cloud.Debugger.V2.ListDebuggeesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListDebuggees, null, options, request);
      }
      /// <summary>
      /// Lists all the debuggees that the user has access to.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Debugger.V2.ListDebuggeesResponse> ListDebuggeesAsync(global::Google.Cloud.Debugger.V2.ListDebuggeesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDebuggeesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all the debuggees that the user has access to.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Debugger.V2.ListDebuggeesResponse> ListDebuggeesAsync(global::Google.Cloud.Debugger.V2.ListDebuggeesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListDebuggees, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override Debugger2Client NewInstance(ClientBaseConfiguration configuration)
      {
        return new Debugger2Client(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(Debugger2Base serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SetBreakpoint, serviceImpl.SetBreakpoint)
          .AddMethod(__Method_GetBreakpoint, serviceImpl.GetBreakpoint)
          .AddMethod(__Method_DeleteBreakpoint, serviceImpl.DeleteBreakpoint)
          .AddMethod(__Method_ListBreakpoints, serviceImpl.ListBreakpoints)
          .AddMethod(__Method_ListDebuggees, serviceImpl.ListDebuggees).Build();
    }

  }
}
#endregion

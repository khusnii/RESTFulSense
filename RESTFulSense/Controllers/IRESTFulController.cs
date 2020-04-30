﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib & Alice Luo  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using RESTFulSense.Models;

namespace RESTFulSense.Controllers
{
    public interface IRESTFulController
    {
        LockedObjectResult Locked(object value);
        BadGatewayObjectResult BadGateway(object value);
        ExpectationFailedObjectResult ExpectationFailed(object value);
        FailedDependencyObjectResult FailedDependency(object value);
        GatewayTimeoutObjectResult GatewayTimeout(object value);
        GoneObjectResult Gone(object value);
        HttpVersionNotSupportedObjectResult HttpVersionNotSupported(object value);
        InsufficientStorageObjectResult InsufficientStorage(object value);
        InternalServerErrorObjectResult InternalServerError(object value);
        LengthRequiredObjectResult LengthRequired(object value);
        LoopDetectedObjectResult LoopDetected(object value);
        MethodNotAllowedObjectResult MethodNotAllowed(object value);
        MisdirectedRequestObjectResult MisdirectedRequest(object value);
        NetworkAuthenticationRequiredObjectResult NetworkAuthenticationRequired(object value);
        NotAcceptableObjectResult NotAcceptable(object value);
        NotExtendedObjectResult NotExtended(object value);
        NotImplementedObjectResult NotImplemented(object value);
        PaymentRequiredObjectResult PaymentRequired(object value);
        PreconditionFailedObjectResult PreconditionFailed(object value);
        PreconditionRequiredObjectResult PreconditionRequired(object value);
        ProxyAuthenticationRequiredObjectResult ProxyAuthenticationRequired(object value);
        RequestedRangeNotSatisfiableObjectResult RequestedRangeNotSatisfiable(object value);
        RequestEntityTooLargeObjectResult RequestEntityTooLarge(object value);
        RequestHeaderFieldsTooLargeObjectResult RequestHeaderFieldsTooLarge(object value);
        RequestTimeoutObjectResult RequestTimeout(object value);
        RequestUriTooLongObjectResult RequestUriTooLong(object value);
        ServiceUnavailableObjectResult ServiceUnavailable(object value);
        TooManyRequestsObjectResult TooManyRequests(object value);
        UnavailableForLegalReasonsObjectResult UnavailableForLegalReasons(object value);
        UnprocessableEntityObjectResult UnprocessableEntity(object value);
    }
}
namespace WebApi.Controllers
open Microsoft.AspNetCore.Mvc
open Newtonsoft.Json.Linq
open System.Net

type FSharpController() =
    inherit ControllerBase()
    
    member __.Accepted() = base.Accepted() :> IActionResult
    member __.Ok() = base.Ok() :> IActionResult
    member __.Created() = base.StatusCode(201) :> IActionResult
    member __.Ok(content : obj) = base.Ok(content) :> IActionResult
    member __.NotFound() = base.NotFound() :> IActionResult
    member __.NoContent() = base.NoContent() :> IActionResult
    member __.BadRequest() = base.BadRequest() :> IActionResult
    member __.BadRequest(error : obj) = base.BadRequest(error) :> IActionResult
    member __.Created(location : string, content) = base.Created(location, content) :> IActionResult
    member __.Created(content) = base.StatusCode(201, content) :> IActionResult
    member __.Conflict() = base.StatusCode(409) :> IActionResult
    member __.Unauthorized() = base.Unauthorized() :> IActionResult
    member __.Unauthorized(error : obj) = base.Unauthorized() :> IActionResult
    member __.Forbidden() = base.Forbid() :> IActionResult
    member __.PreConditionFailed() = base.StatusCode(412) :> IActionResult
    member __.ServiceUnavailable() = base.StatusCode(503) :> IActionResult
    member __.ServiceUnavailable(content : obj) = base.StatusCode(503, content) :> IActionResult
    member __.StatusCode(status : int) = base.StatusCode(status) :> IActionResult
    member __.StatusCode(data : obj, status : int) = base.StatusCode(status, data) :> IActionResult
    member __.Forbidden(data : obj) = base.StatusCode(403, data) :> IActionResult
    member __.EntityTooLarge(data : obj) = base.StatusCode(413, data) :> IActionResult
    member __.TooManyRequests(data : obj) = base.StatusCode(429, data) :> IActionResult
    member __.NotModified() = base.StatusCode(304) :> IActionResult

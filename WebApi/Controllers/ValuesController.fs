namespace WebApi.Controllers

open Microsoft.AspNetCore.Mvc
open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks

[<Route("api/test")>]
[<ApiController>]
type ValuesController() =
    inherit FSharpController()
    
    [<HttpGet>]
    member this.Get() = async { return this.BadRequest("Not Implemented") }
    
    [<HttpGet("{id}")>]
    member this.Get(id : int) = async { return this.BadRequest("Not Implemented") }
    
    [<HttpPut("{id}")>]
    member this.Put(id : int, [<FromBody>] value : string) = async { return this.BadRequest("Not Implemented") }
    
    [<HttpDelete("{id}")>]
    member this.Delete(id : int) = async { return this.BadRequest("Not Implemented") }

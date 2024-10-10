namespace repo

type Response = Response

[<AbstractClass>]
type Fetcher() =
    abstract member api: model.Date -> string -> Response list
    abstract member of_stock: (Response) -> model.Stock

    member this.fetchs (date: model.Date) (sid: string) : model.Stock list =
        this.api date sid |> List.map (this.of_stock)

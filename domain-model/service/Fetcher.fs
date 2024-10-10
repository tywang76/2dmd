namespace service

type Market =
    | Otc
    | Tse
    | Other

module Fetcher =
    let getMarket (sid: string) : Market = Other

    let getFetcher (sid: string) : repo.Fetcher =
        match getMarket sid with
        | Otc -> repo.TPEXFetcher()
        | Tse -> repo.TWSEFetcher()
        | Other -> failwith "Can't find the market with this stock id"

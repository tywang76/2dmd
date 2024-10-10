namespace service

type MAConfig = { scale: int; bar: model.bar }

type MA =
    member this.gets (sids: string list, config: MAConfig) : (float list list) =
        sids
        |> List.map (Stock.fetchs (config.scale))
        |> List.map (common.MA.get_ma (config.bar))

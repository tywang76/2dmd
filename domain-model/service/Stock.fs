namespace service

module Stock =
    let fetchs (amount: int) (sid: string) : model.Stock list =
        let repo = Fetcher.getFetcher (sid)
        let dt = common.Date.today
        repo.fetchs dt sid |> List.take amount

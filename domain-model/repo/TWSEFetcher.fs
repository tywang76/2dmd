namespace repo

//     { stat: string
//       date: common.DateADExp
//       title: string
//       fields: string list
//       data: string list }

type TWSEResponse = Response

type TWSEFetcher() =
    inherit Fetcher()

    override this.api (arg: model.Date) (arg_1: string) : TWSEResponse list =
        raise (System.NotImplementedException())

    override this.of_stock(arg: TWSEResponse) : model.Stock =
        raise (System.NotImplementedException())

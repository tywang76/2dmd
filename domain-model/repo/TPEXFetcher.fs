namespace repo

//     { stkNo: string
//       stkName: common.DateTWExp
//       showListPriceNote: bool
//       showListPriceLink: bool
//       reportDate: string
//       iTotalRecords: int
//       aaData: string list }

type TPEXResponse = Response

type TPEXFetcher() =
    inherit Fetcher()

    override this.api (arg: model.Date) (arg_1: string) : TPEXResponse list =
        raise (System.NotImplementedException())

    override this.of_stock(arg: TPEXResponse) : model.Stock =
        raise (System.NotImplementedException())

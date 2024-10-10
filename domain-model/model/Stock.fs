namespace model

type Date = { year: int; month: int; day: int }

type bar =
    { ``open``: int
      high: int
      low: int
      close: int }

type Stock =
    { date: string
      capacity: int
      turnover: int
      bar: bar
      change: int
      transaction: int }

export interface IItemPagination {
  items: IItem[]
  pageNumber: number
  totalPages: number
  totalCount: number
  hasPreviousPage: boolean
  hasNextPage: boolean
}

export interface IDashboardItem {
  browwed: string
  sold: string
  store: string
  total: string

  degitalCheck: string
  brabouz: string
  panini: string
  xerox: string
  brands:any
  customers:any
  scanner: number[] 
  parts: number[] 
  printer: number[]
}
export interface IItem {
  partNumber: string
  oracleCode: string
  warehouseCode: string
  name: string
  model: string
  description: string
  itemTypeId: number
  brandId: number
  warehouseId: number
  image: string
}


export interface IItemType {
  id: number
  name: string
  description: string
}

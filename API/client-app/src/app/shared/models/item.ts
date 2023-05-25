export interface IItemPagination {
  items: IItem[]
  pageNumber: number
  totalPages: number
  totalCount: number
  hasPreviousPage: boolean
  hasNextPage: boolean
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

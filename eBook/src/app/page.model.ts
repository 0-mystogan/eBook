export interface Page{
   pageNumber : number,
   pageSize: number,
   firstPage: string,
   lastPage: string,
   totalPages: number,
   totalRecords: number,
   nextPage: string,
   previousPage: string,
   data: any
}
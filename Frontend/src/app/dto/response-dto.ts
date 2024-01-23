export class ResponseDto<T> {
  constructor(public data: T | null, public isSuccess: boolean) {}
}

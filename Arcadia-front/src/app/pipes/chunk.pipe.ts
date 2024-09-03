import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'chunk',
  standalone: true
})
export class ChunkPipe implements PipeTransform {
  transform(array: any[], chunkSize: number, startIndex: number): any[] {
    const result: any[] = [];

    for (let i = startIndex; i < array.length; i ++) {
      result.push(array.slice(i, i + chunkSize));
      if (i + chunkSize >= array.length) break;
    }
    
    return result;
  }
}
 
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'reminder'
})
export class ReminderPipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    return null;
  }

}

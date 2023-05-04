import { Pipe, PipeTransform } from '@angular/core';
import { Money } from '../Models/Money';

@Pipe({
  name: 'changeMoney'
})
export class ChangeMoneyPipe implements PipeTransform {

  transform(value: number, moneySelect : Money): string {
    return (value * moneySelect.TAX).toLocaleString();
  }

}

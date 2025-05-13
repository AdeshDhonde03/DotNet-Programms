import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-counter',
  imports: [],
  templateUrl: './counter.component.html',
  styleUrl: './counter.component.css'
})
export class CounterComponent {
@Input()count:number=0;

increment(){
  this.count++;
}

handleInput(e :Event){
 this.count=Number( (e.target as HTMLInputElement).value);

}



}

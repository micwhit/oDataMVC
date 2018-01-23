import { Component, ViewContainerRef } from '@angular/core';
import { AlertComponent } from 'ng2-bootstrap/ng2-bootstrap';
import { NgModel } from '@angular/forms';
@Component({
    selector: 'my-app',
    template: ` 
      <user-detail>Loading...</user-detail>
      <product-form>Loading...</product-form>
   `
})
export class AppComponent {
    private viewContainerRef: ViewContainerRef;
    public constructor(viewContainerRef: ViewContainerRef) {
        // You need this small hack in order to catch application 
        // root view container ref
        this.viewContainerRef = viewContainerRef;
    }
}

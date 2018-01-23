import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { Ng2BootstrapModule } from 'ng2-bootstrap/ng2-bootstrap';
import { UserService } from './user/user.service';
import { ProductService } from './product/product.service';
import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';
import { ProductComponent } from './product/product.component';
@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        FormsModule,
        Ng2BootstrapModule
    ],
    declarations: [
        AppComponent,
        UserComponent,
        ProductComponent
    ],
    providers: [
        UserService,
        ProductService
    ],
    bootstrap: [
        AppComponent
    ]
})
export class AppModule { }
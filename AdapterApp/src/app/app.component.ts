import { Component } from '@angular/core';
import{HttpClient, HttpParams }from '@angular/common/http';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AdapterApp';
  DisplayBase64 = "";
  constructor(private https: HttpClient){}


  onChangetoBase64(data: any )
  {
    return this.https.post('https://localhost:44387/Data/ChangetoBase64?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickChangetoHex(data: any )
  {
    return this.https.post('https://localhost:44387/Data/ChangetoHex?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickChangetoBinary(data: any )
  {
    return this.https.post('https://localhost:44387/Data/ChangetoBinary?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickChangetoWords(data: any )
  {
    return this.https.post('https://localhost:44387/Data/ChangetoWords?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBinarytoString(data: any )
  {
    return this.https.post('https://localhost:44387/Data/BinarytoString?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBase64toString(data: any )
  {
    return this.https.post('https://localhost:44387/Data/Base64toString?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickStringtoByte(data: any )
  {
    return this.https.post('https://localhost:44387/Data/StringtoByte?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBytetoString(data: any )
  {
    return this.https.post('https://localhost:44387/Data/BytetoString?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickHextoString(data: any )
  {
    return this.https.post('https://localhost:44387/Data/HextoString?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickHextoBase64(data: any )
  {
    return this.https.post('https://localhost:44387/Data/HextoBase64?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickHextoBinary(data: any )
  {
    return this.https.post('https://localhost:44387/Data/HextoBinary?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickHextoByte(data: any )
  {
    return this.https.post('https://localhost:44387/Data/HextoByte?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBase64toHex(data: any )
  {
    return this.https.post('https://localhost:44387/Data/Base64toHex?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBase64toBinary(data: any )
  {
    return this.https.post('https://localhost:44387/Data/Base64toBinary?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBase64toByte(data: any )
  {
    return this.https.post('https://localhost:44387/Data/Base64toByte?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBytetoBase64(data: any )
  {
    return this.https.post('https://localhost:44387/Data/BytetoBase64?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBytetoHex(data: any )
  {
    return this.https.post('https://localhost:44387/Data/BytetoHex?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBytetoBinary(data: any )
  {
    return this.https.post('https://localhost:44387/Data/BytetoBinary?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBinarytoBase64(data: any )
  {
    return this.https.post('https://localhost:44387/Data/BinarytoBase64?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBinarytoHex(data: any )
  {
    return this.https.post('https://localhost:44387/Data/BinarytoHex?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
  onClickBinarytoByte(data: any )
  {
    return this.https.post('https://localhost:44387/Data/BinarytoByte?data='+ data.abc,null,{responseType: 'text'})
    .subscribe((res)=>{
      this.DisplayBase64 = res;
      console.log("Result: ",res);
    })
  }
}

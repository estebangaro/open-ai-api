import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public responses: openAIChatGptResponse[];
  public loading: boolean;
  public response?: any;
  public txtResponse: any;
  public txtQuestion: string;

  constructor(private http: HttpClient) {
    this.responses = [];
    this.txtResponse = undefined;
    this.txtQuestion = "";
    this.loading = false;
  }

  public sendQuestion(): void {
    this.loading = true;
    this.txtResponse = "Obteniendo respuesta de OpenAI API...";
    this.http.post<any>('openapi', {
      question: this.txtQuestion
    }).subscribe(result => {
      this.txtResponse = "";
      this.loading = false;
      if (result.response) {
        result.question = this.txtQuestion;
        this.txtQuestion = "";
        this.responses.push(result);
      }
    }, error => {
      this.loading = false;
      this.txtResponse = "Ha ocurrido un problema al obtener la respuesta...";
      console.error(error);
    });
  }
}

interface openAIChatGptResponse {
  question: string;
  response: string;
}

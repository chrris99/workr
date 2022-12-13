import { Component, OnInit } from '@angular/core';
import { UntypedFormBuilder, UntypedFormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/shared/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {
  title: string = 'Get started today! 💪';
  description: string = 'Become the best version of yourself! Create and manage exercises, workout templates and workout plans!';

  form: UntypedFormGroup;

  constructor(private formBuilder: UntypedFormBuilder, private auth: AuthService) {
    this.form = this.formBuilder.group({
      email: [ '', [Validators.required] ],
      password: [ '', [Validators.required] ]
    });
  }

  ngOnInit(): void { }

  public login(): void {
    const data = this.form.value;

    if (data.email && data.password) {
      this.auth.login(data.email, data.password);
    }
  }
}

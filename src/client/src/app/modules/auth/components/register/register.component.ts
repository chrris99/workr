import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/shared/services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html'
})
export class RegisterComponent implements OnInit {
  title: string = 'Get started today! 💪';
  description: string = 'Become the best version of yourself! Create and manage exercises, workout templates and workout plans!';

  form: FormGroup;

  constructor(
    private auth: AuthService,
    private formBuilder: FormBuilder
  ) {
    this.form = formBuilder.group({
      name: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(8)]]
    });
  }

  ngOnInit(): void { }

  public register(): void {
    const data = this.form.value;

    if (data.email && data.password && data.name) {
      this.auth
        .register(data.email, data.name, data.password);
    }
  }
}

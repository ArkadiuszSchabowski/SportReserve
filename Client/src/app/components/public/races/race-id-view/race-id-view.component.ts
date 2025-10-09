import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/_services/auth.service';
import { RaceService } from 'src/app/_services/race.service';
import { environment } from 'src/environments/environment';
import { GetRaceViewDto } from 'src/app/models/race/get-race-view-dto';

@Component({
  selector: 'app-race-id-view',
  templateUrl: './race-id-view.component.html',
  styleUrls: ['./race-id-view.component.scss'],
})
export class RaceIdViewComponent {
  constructor(
    private authService: AuthService,
    private router: Router,
    private activatedRoute: ActivatedRoute,
    private raceService: RaceService
  ) {}

  id: number = 0;
  currentUser: string | null = null;
  race: GetRaceViewDto = {} as GetRaceViewDto;
  raceSlug: string = '';
  raceUrl = environment.raceUrl;

  ngOnInit(): void {
    this.getRace();
    this.setUser();
  }

  getRace() {
    const raceIdString = this.getRaceIdFromUrl();
    if (raceIdString) {
      const id: number = this.convertIdToNumber(raceIdString);
      this.id = id;
      this.raceService.getRaceViewWithId(id).subscribe({
        next: (response) => {
          this.race = response;
          this.raceSlug = this.convertToSlug(this.race.name);
        },
      });
    }
  }
  convertIdToNumber(stringId: string): number {
    return parseInt(stringId);
  }

  convertToSlug = (text: string): string => {
    return text.toLowerCase().replace(/ /g, '-');
  };

  getRaceIdFromUrl(): string | null {
    return this.activatedRoute.snapshot.paramMap.get('id');
  }

  goToForm() {
    if (!this.currentUser) {
      this.router.navigateByUrl('login');
    } else {
      this.router.navigateByUrl(`${this.raceSlug}/form/${this.id}`);
    }
  }
  setUser() {
    this.authService.currentUser$.subscribe({
      next: (response) => {
        this.currentUser = response;
      },
    });
  }
}

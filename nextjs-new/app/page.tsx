import Link from "next/link";

const features = [
  "Course notes",
  "Photo diary",
  "Project portfolio",
  "CV and profile",
];

export default function Home() {
  return (
    <main className="min-h-screen px-6 py-10 sm:px-10">
      <section className="mx-auto flex max-w-5xl flex-col gap-10 rounded-[2rem] border border-amber-200 bg-white/75 p-8 shadow-2xl shadow-amber-950/10 backdrop-blur sm:p-12">
        <div className="flex flex-col gap-4">
          <p className="text-sm font-semibold uppercase tracking-[0.35em] text-amber-700">Menmen&apos;s Golden House</p>
          <h1 className="max-w-3xl text-4xl font-bold tracking-tight text-stone-950 sm:text-6xl">
            Rebuilding the Golden House as a full-stack personal platform.
          </h1>
          <p className="max-w-2xl text-lg leading-8 text-stone-700">
            This Next.js frontend is now tracked as normal source code, paired with the ASP.NET Core API backend.
          </p>
        </div>

        <div className="grid gap-4 sm:grid-cols-2 lg:grid-cols-4">
          {features.map((feature) => (
            <div key={feature} className="rounded-2xl border border-amber-100 bg-amber-50/80 p-5 font-medium text-stone-800">
              {feature}
            </div>
          ))}
        </div>

        <div className="flex flex-wrap gap-3">
          <Link className="rounded-full bg-stone-950 px-5 py-3 text-sm font-semibold text-white" href="/health">
            Check API health
          </Link>
          <a className="rounded-full border border-stone-300 px-5 py-3 text-sm font-semibold text-stone-800" href="http://localhost:5000/swagger/index.html">
            Open Swagger
          </a>
        </div>
      </section>
    </main>
  );
}

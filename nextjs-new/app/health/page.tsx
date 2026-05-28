import { API_ENDPOINTS, API_BASE_URL } from "@/lib/api";

async function getHealthStatus() {
  try {
    const response = await fetch(API_ENDPOINTS.health, { cache: "no-store" });

    if (!response.ok) {
      return { ok: false, message: `Backend returned HTTP ${response.status}` };
    }

    const data = (await response.json()) as { status?: string; timestamp?: string };
    return { ok: true, message: data.status ?? "healthy", timestamp: data.timestamp };
  } catch (error) {
    return {
      ok: false,
      message: error instanceof Error ? error.message : "Unable to reach backend",
    };
  }
}

export default async function HealthPage() {
  const health = await getHealthStatus();

  return (
    <main className="min-h-screen px-6 py-10 sm:px-10">
      <section className="mx-auto max-w-3xl rounded-[2rem] border border-amber-200 bg-white/80 p-8 shadow-xl shadow-amber-950/10 sm:p-10">
        <p className="text-sm font-semibold uppercase tracking-[0.3em] text-amber-700">API Health</p>
        <h1 className="mt-3 text-4xl font-bold text-stone-950">Backend connection status</h1>
        <div className="mt-8 rounded-2xl border border-stone-200 bg-stone-50 p-6">
          <p className={health.ok ? "font-semibold text-emerald-700" : "font-semibold text-red-700"}>
            {health.ok ? "Connected" : "Not connected"}
          </p>
          <p className="mt-2 text-stone-700">{health.message}</p>
          {health.timestamp ? <p className="mt-2 text-sm text-stone-500">Timestamp: {health.timestamp}</p> : null}
        </div>
        <p className="mt-6 text-sm text-stone-600">API base URL: {API_BASE_URL}</p>
      </section>
    </main>
  );
}
